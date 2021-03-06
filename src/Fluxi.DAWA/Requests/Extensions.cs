﻿using Fluxi.DAWA.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Fluxi.DAWA.Requests
{
    public static class Extensions
    {
        public static string GetParameterName(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    if (Attribute.GetCustomAttribute(field, typeof(ParameterDescriptionAttribute)) is ParameterDescriptionAttribute attr)
                        return attr.ParameterName;
                }
            }

            return null;
        }

        public static SearchBase<Address> AddParameter(this SearchBase<Address> ar, AddressParam param, string value)
        {
            ar.ApiRequest.AddQueryParameter(param.GetParameterName(), value);

            return ar;
        }

        public static SearchBase<AccessAddress> AddParameter(this SearchBase<AccessAddress> ar, AccessAddressParam param, string value)
        {
            ar.ApiRequest.AddQueryParameter(param.GetParameterName(), value);

            return ar;
        }

        public static SearchBase<ZipcodeDetails> AddParameter(this SearchBase<ZipcodeDetails> ar, ZipcodeParam param, string value)
        {
            ar.ApiRequest.AddQueryParameter(param.GetParameterName(), value);

            return ar;
        }

        public static SearchBase<RoadsegmentDetails> AddParameter(this SearchBase<RoadsegmentDetails> ar, RoadsegmentParam param, string value)
        {
            ar.ApiRequest.AddQueryParameter(param.GetParameterName(), value);

            return ar;
        }

        public static async Task<List<T>> Execute<T>(this SearchBase<T> ar) where T : class
        {
            var response = await ar.ApiClient.ExecuteTaskAsync<List<T>>(ar.ApiRequest);

            return response.Data;
        }

        public static async Task<T> Execute<T>(this GetBase<T> ar) where T : class
        {
            var response = await ar.ApiClient.ExecuteTaskAsync<T>(ar.ApiRequest);

            return response.Data;
        }
    }
}
