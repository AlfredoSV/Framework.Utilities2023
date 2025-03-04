﻿using Microsoft.Extensions.Configuration;

namespace Framework.Utilities
{
    public class ConnectionStrUtilities
    {
        private string _connectionStr;

        private IConfiguration _configuration;

        public ConnectionStrUtilities(IConfiguration config)
        {
            this._configuration = config;
        }

        public ConnectionStrUtilities(){}


        public string StrConnectionFrameworkUtilities
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionStr))
                {
                    _connectionStr = this._configuration["DataBase:ConnectionStrUtilities"];
                    ArgumentException.ThrowIfNullOrWhiteSpace(_connectionStr, nameof(_connectionStr));
                }

                return _connectionStr;
            }

            set { }
        }

    }
}
