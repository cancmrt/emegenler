﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmegenlerMvcPlayground.Context;
using EmegenlerMvcPlayground.Logic.PaginationLogic;
using EmegenlerMvcPlayground.Models;
using EmegenlerMvcPlayground.Models.ViewModels;
using Guard.Emegenler.Domains.Decorators;
using Guard.Emegenler.FluentInterface;
using Guard.Emegenler.FluentInterface.Policy.Types;
using Guard.Emegenler.FluentInterface.Policy.UserStyles;
using Guard.Emegenler.Policy.FluentInterface.PolicyAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmegenlerMvcPlayground.Controllers
{
    public class PermissionController : Controller
    {
        private readonly IEmegenlerFluentApi API;
        PlaygroundContext _context;
        public PermissionController(IEmegenlerFluentApi api, PlaygroundContext context)
        {
            API = api;
            _context = context;
        }
        public IActionResult Index(int ChoosedPage)
        {
            long TotalCountOfPolicy = API.Policy.Count();
            long ElementRowCountOnPage = 10;
            var Paginate = Pagination.Calculate(TotalCountOfPolicy, ChoosedPage, ElementRowCountOnPage);
            var Policies = API.Policy.Take(Convert.ToInt32(Paginate.CurrentPage), Convert.ToInt32(Paginate.RangeSize));

            ViewData["Policies"] = MapEmegenlerPolicy_TO_PolictView(Policies);
            ViewData["Paginate"] = Paginate;
            return View();
        }
        public IActionResult Add()
        {
            ViewData["Users"] = _context.Users.ToList();
            ViewData["Groups"] = _context.Groups.ToList();

            Dictionary<string, string> Pages = new Dictionary<string, string>();
            Pages.Add("Add Permissions", "permission/add");
            Pages.Add("Edit Permissions", "permission/edit");
            Pages.Add("Remove Permissions", "permission/delete");
            Pages.Add("Permissions All", "permission/*");

            Dictionary<string, string> Reports = new Dictionary<string, string>();
            Reports.Add("Sales Reports", ".salessection");
            Reports.Add("IT Reports", ".itsection");
            Reports.Add("HR Reports", ".hrsection");

            Dictionary<string, string> Forms = new Dictionary<string, string>();
            Forms.Add("Sale Report Form", "#SaleReportForm");
            Forms.Add("It Report Form", "#ItReportForm");
            Forms.Add("HR Report Form", "#HrReportForm");


            string[] PageAccessRules = new string[] { "Access Granted", "Access Denied" };
            string[] ReportsAccessRules = new string[] { "Show", "Hide" };
            string[] FormAccessRules = new string[] { "Action Granted", "Readonly", "Hide" };

            ViewData["Pages"] = Pages;
            ViewData["Reports"] = Reports;
            ViewData["Forms"] = Forms;

            ViewData["PageRules"] = PageAccessRules;
            ViewData["ReportRules"] = ReportsAccessRules;
            ViewData["FormRules"] = FormAccessRules;



            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormCollection form)
        {
            var PolicyCreation = API.Policy.Create();
            IEmegenlerPolicyAccess AuthBase = null;
            if(form["SelectedAccessRole"] == "1")
            {
                AuthBase = PolicyCreation.WithUser(form["SelectedUser"]);
            }
            else if (form["SelectedAccessRole"] == "2")
            {
                AuthBase = PolicyCreation.WithRole(form["SelectedGroup"]);
            }
            if(form["SelectedElementType"] == "1")
            {
                var PagePolicy = AuthBase.AddPage(form["SelectedPage"]);
                if(form["SelectedPageRule"] == "Access Granted")
                {
                    PagePolicy.AccessGranted();
                }
                else if(form["SelectedPageRule"] == "Access Denied")
                {
                    PagePolicy.AccessDenied();
                }
            }
            else if(form["SelectedElementType"] == "2")
            {
                var ReportPolicy = AuthBase.AddComponent(form["SelectedReport"]);
                if (form["SelectedReportRule"] == "Show")
                {
                    ReportPolicy.Show();
                }
                else if (form["SelectedReportRule"] == "Hide")
                {
                    ReportPolicy.Hide();
                }
            }
            else if(form["SelectedElementType"] == "3")
            {
                var FormPolicy = AuthBase.AddForm(form["SelectedForm"]);
                if (form["SelectedFormRule"] == "Action Granted")
                {
                    FormPolicy.ActionGranted();
                }
                else if (form["SelectedFormRule"] == "Readonly")
                {
                    FormPolicy.Readonly();
                }
                else if (form["SelectedFormRule"] == "Hide")
                {
                    FormPolicy.Hide();
                }
            }

            return RedirectToAction("Index");
        }

        private List<PolicyView> MapEmegenlerPolicy_TO_PolictView(IList<EmegenlerPolicyDecorator> Policies)
        {
            var policiesAccessRoles = Policies.Select(x => new
            {
                AuthType = x.AuthBase,
                Identifier = x.AuthBaseIdentifier
            }).Distinct().Where(a => a.AuthType == AuthBase.Role);

            var RoleList = new List<Group>();

            foreach (var role in policiesAccessRoles)
            {
                var dbRole = _context.Groups.Where(gr => gr.Id == Convert.ToInt32(role.Identifier)).FirstOrDefault();
                RoleList.Add(dbRole);

            }


            var policiesAccessUsers = Policies.Select(x => new
            {
                AuthType = x.AuthBase,
                Identifier = x.AuthBaseIdentifier
            }).Distinct().Where(a => a.AuthType == AuthBase.User);


            var UserList = new List<User>();

            foreach (var user in policiesAccessUsers)
            {
                var dbUser = _context.Users.Where(gr => gr.Id == Convert.ToInt32(user.Identifier)).FirstOrDefault();
                UserList.Add(dbUser);
            }


            var ListOfPolicyViews = new List<PolicyView>();

            var localMapConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmegenlerPolicyDecorator, PolicyView>();
            });

            IMapper autoMapper = localMapConfiguration.CreateMapper();

            foreach (var policy in Policies)
            {
                var policyView = new PolicyView();
                autoMapper.Map(policy, policyView);

                if (policy.AuthBase == AuthBase.Role)
                {
                    var getRoleName = RoleList
                        .Where(r => r.Id == Convert.ToInt32(policy.AuthBaseIdentifier))
                        .FirstOrDefault()
                        .Name;
                    policyView.IdentifierName = getRoleName;
                }
                if (policy.AuthBase == AuthBase.User)
                {
                    var getUser = UserList
                        .Where(r => r.Id == Convert.ToInt32(policy.AuthBaseIdentifier))
                        .FirstOrDefault();

                    var getUserName = getUser.Name + " " + getUser.Surname;

                    policyView.IdentifierName = getUserName;
                }

                ListOfPolicyViews.Add(policyView);
            }

            return ListOfPolicyViews;

        }
    }
}