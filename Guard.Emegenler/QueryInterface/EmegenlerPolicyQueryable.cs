using Guard.Emegenler.FluentInterface.Policy.UserStyles;
using Guard.Emegenler.Policy.FluentInterface.PolicyAccess;
using Guard.Emegenler.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.QueryInterface
{
    public static class EmegenlerPolicyQueryable
    {

        public static void Query(this IEmegenlerPolicyAuthBase authCreate, string query)
        {
            
            
            var splittedQuery = query.Split("->");
            if(splittedQuery.Length != 3)
            {
                throw new ArgumentOutOfRangeException("Query must have 3 level UserType->ElementType-AccessType");
            }
            if (splittedQuery[0].Contains(UserType.User))
            {
                string output = GetParanthesisInsideValue(splittedQuery[0]);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new NullReferenceException("We didn't find any User identifier");
                }
                authCreate.WithUser(output).ElementQueryDefine(splittedQuery[0]);

            }
            else if(splittedQuery[0].Contains(UserType.Role))
            {
                string output = GetParanthesisInsideValue(splittedQuery[0]);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new NullReferenceException("We didn't find any Role identifier");
                }
                authCreate.WithRole(output).ElementQueryDefine(splittedQuery[0]);
            }
            else
            {
                throw new ArgumentException("UserType level couldn't find, Did you missed User or Role keyword");
            }
        }
        private static void ElementQueryDefine(this IEmegenlerPolicyAccess elementPolicy, string query)
        {
            if(query.Contains(ElementType.Page))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new NullReferenceException("We didn't find any Page identifier");
                }
                elementPolicy.AddPage(output);
            }
            else if (query.Contains(ElementType.Component))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new NullReferenceException("We didn't find any Component identifier");
                }
                elementPolicy.AddComponent(output);
            }
            else if (query.Contains(ElementType.Form))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new NullReferenceException("We didn't find any Form identifier");
                }
                elementPolicy.AddForm(output);
            }
            else if (query.Contains(ElementType.Form))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new NullReferenceException("We didn't find any Form identifier");
                }
                elementPolicy.AddForm(output);
            }
            else if (query.Contains(ElementType.Input))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new NullReferenceException("We didn't find any Input identifier");
                }
                elementPolicy.AddInput(output);
            }
            else if (query.Contains(ElementType.Button))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new NullReferenceException("We didn't find any Button identifier");
                }
                elementPolicy.AddButton(output);
            }
            else if (query.Contains(ElementType.Link))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new NullReferenceException("We didn't find any Link identifier");
                }
                elementPolicy.AddLink(output);
            }
            else
            {
                throw new ArgumentException("ElementType level couldn't find, Did you missed Page,Component,Form... etc keywords");
            }
        }
        private static string GetParanthesisInsideValue(string query)
        {
            return query.Split('(', ')')[1];
        }
    }
}
