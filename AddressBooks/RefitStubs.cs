﻿﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using Refit;
using System.Text;
using System.Threading.Tasks;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {
#pragma warning disable 0649
        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
#pragma warning restore 0649
    }
}

namespace AddressBooks
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIAddressBookApi : IAddressBookApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIAddressBookApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<Dictionary<string, string>> CreateApiToken(Dictionary<string, string> user)
        {
            var arguments = new object[] { user };
            return (Task<Dictionary<string, string>>) methodImpls["CreateApiToken"](Client, arguments);
        }

        public virtual Task<User> GetCurrentUser(string authorization)
        {
            var arguments = new object[] { authorization };
            return (Task<User>) methodImpls["GetCurrentUser"](Client, arguments);
        }

        public virtual Task<RestAddressBookPage> GetAddressBooks(int page,string authorization)
        {
            var arguments = new object[] { page,authorization };
            return (Task<RestAddressBookPage>) methodImpls["GetAddressBooks"](Client, arguments);
        }

        public virtual Task<AddressBook> GetAddressBook(int id,string authorization)
        {
            var arguments = new object[] { id,authorization };
            return (Task<AddressBook>) methodImpls["GetAddressBook"](Client, arguments);
        }

        public virtual Task<List<Group>> GetGroups(int page,string authorization)
        {
            var arguments = new object[] { page,authorization };
            return (Task<List<Group>>) methodImpls["GetGroups"](Client, arguments);
        }

        public virtual Task<Group> GetGroup(int id,string authorization)
        {
            var arguments = new object[] { id,authorization };
            return (Task<Group>) methodImpls["GetGroup"](Client, arguments);
        }

    }
}


