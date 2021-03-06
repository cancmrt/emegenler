﻿using Guard.Emegenler.FluentInterface.Policy.UserStyles;
using Guard.Emegenler.Policy.FluentInterface.PolicyAccess;
using Guard.Emegenler.Types;
using System;
namespace Guard.Emegenler.QueryInterface
{
    public static class EmegenlerPolicyQueryable
    {
        /// <summary>
        /// This extension parse policy using string query
        /// </summary>
        /// <param name="authCreate">extension Policy Authbase</param>
        /// <param name="query">String query</param>
        public static void ByQuery(this IEmegenlerPolicyAuthBase authCreate, string query)
        {
            
            
            var splittedQuery = query.Split("->");
            if(splittedQuery.Length != 3)
            {
                throw new ArgumentException("Query must have 3 level UserType->ElementType-AccessType");
            }
            if (splittedQuery[0].Contains(UserType.User))
            {
                string output = GetParanthesisInsideValue(splittedQuery[0]);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new ArgumentException("We didn't find any User identifier");
                }
                authCreate.WithUser(output).ElementQueryDefine(splittedQuery[1],splittedQuery[2]);

            }
            else if(splittedQuery[0].Contains(UserType.Role))
            {
                string output = GetParanthesisInsideValue(splittedQuery[0]);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new ArgumentException("We didn't find any Role identifier");
                }
                authCreate.WithRole(output).ElementQueryDefine(splittedQuery[1],splittedQuery[2]);
            }
            else
            {
                throw new ArgumentException("UserType level couldn't find, Did you missed User or Role keyword");
            }
        }
        /// <summary>
        /// Parse query by Element type
        /// </summary>
        /// <param name="elementPolicy">extension PolicyAccess</param>
        /// <param name="query">String query written by User</param>
        /// <param name="nextQuery">Next part of query</param>
        private static void ElementQueryDefine(this IEmegenlerPolicyAccess elementPolicy, string query, string nextQuery)
        {
            if(query.Contains(ElementType.Page))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new ArgumentException("We didn't find any Page identifier");
                }
                var nextStepOfPolicy = elementPolicy.AddPage(output);
                if(nextQuery == AccessProtocol.AccessGranted)
                {
                    nextStepOfPolicy.AccessGranted();
                }
                else if(nextQuery == AccessProtocol.AccessDenied)
                {
                    nextStepOfPolicy.AccessDenied();
                }
                else
                {
                    throw new ArgumentException("We didn't find sended AccessType, In Page types should be: AccessGranted and AccessDenied");
                }
            }
            else if (query.Contains(ElementType.Component))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new ArgumentException("We didn't find any Component identifier");
                }
                var nextStepOfPolicy = elementPolicy.AddComponent(output);
                if(nextQuery == AccessProtocol.Show)
                {
                    nextStepOfPolicy.Show();
                }
                else if(nextQuery == AccessProtocol.Hide)
                {
                    nextStepOfPolicy.Hide();
                }
                else
                {
                    throw new ArgumentException("We didn't find sended AccessType, In Component types should be: Show and Hide");
                }
            }
            else if (query.Contains(ElementType.Form))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new ArgumentException("We didn't find any Form identifier");
                }
                var nextStepOfPolicy = elementPolicy.AddForm(output);
                if(nextQuery == AccessProtocol.ActionGranted)
                {
                    nextStepOfPolicy.ActionGranted();
                }
                else if(nextQuery == AccessProtocol.Readonly)
                {
                    nextStepOfPolicy.Readonly();
                }
                else if(nextQuery == AccessProtocol.Hide)
                {
                    nextStepOfPolicy.Hide();
                }
                else
                {
                    throw new ArgumentException("We didn't find sended AccessType, In Form types should be: ActionGranted,Readonly and Hide");
                }
            }
            else if (query.Contains(ElementType.Input))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new ArgumentException("We didn't find any Input identifier");
                }
                var nextStepOfPolicy = elementPolicy.AddInput(output);
                if(nextQuery == AccessProtocol.Editable)
                {
                    nextStepOfPolicy.Editable();
                }
                else if(nextQuery == AccessProtocol.Readonly)
                {
                    nextStepOfPolicy.Readonly();
                }
                else if(nextQuery == AccessProtocol.Hide)
                {
                    nextStepOfPolicy.Hide();
                }
                else
                {
                    throw new ArgumentException("We didn't find sended AccessType, In Input types should be: Editable,Readonly and Hide");
                }
            }
            else if (query.Contains(ElementType.Button))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new ArgumentException("We didn't find any Button identifier");
                }
                var nextStepOfPolicy = elementPolicy.AddButton(output);
                if (nextQuery == AccessProtocol.ActionGranted)
                {
                    nextStepOfPolicy.ActionGranted();
                }
                else if (nextQuery == AccessProtocol.Readonly)
                {
                    nextStepOfPolicy.Readonly();
                }
                else if (nextQuery == AccessProtocol.Hide)
                {
                    nextStepOfPolicy.Hide();
                }
                else
                {
                    throw new ArgumentException("We didn't find sended AccessType, In Button types should be: ActionGranted,Readonly and Hide");
                }
            }
            else if (query.Contains(ElementType.Link))
            {
                string output = GetParanthesisInsideValue(query);
                if (string.IsNullOrWhiteSpace(output))
                {
                    throw new ArgumentException("We didn't find any Link identifier");
                }
                var nextStepOfPolicy = elementPolicy.AddLink(output);
                if (nextQuery == AccessProtocol.ActionGranted)
                {
                    nextStepOfPolicy.ActionGranted();
                }
                else if (nextQuery == AccessProtocol.Readonly)
                {
                    nextStepOfPolicy.Readonly();
                }
                else if (nextQuery == AccessProtocol.Hide)
                {
                    nextStepOfPolicy.Hide();
                }
                else
                {
                    throw new ArgumentException("We didn't find sended AccessType, In Link types should be: ActionGranted,Readonly and Hide");
                }
            }
            else
            {
                throw new ArgumentException("ElementType level couldn't find, Did you missed Page,Component,Form... etc keywords");
            }
        }
        /// <summary>
        /// Getting inside of () paranthesis
        /// </summary>
        /// <param name="query">String query</param>
        /// <returns>Inside of () paranthesis</returns>
        private static string GetParanthesisInsideValue(string query)
        {
            return query.Split('(', ')')[1];
        }
    }
}
