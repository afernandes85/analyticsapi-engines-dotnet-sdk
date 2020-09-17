using System;

namespace FactSet.AnalyticsAPI.Engines.Test.Api
{
    public static class CommonParameters
    {
        // Add 'ANALYTICS_API_USERNAME_SERIAL' environment variable with username-serial as value
        public static readonly string UserName = Environment.GetEnvironmentVariable("ANALYTICS_API_USERNAME_SERIAL");

        // Add 'ANALYTICS_API_PASSWORD' environment variable with the api key generated on developer portal
        public static readonly string Password = Environment.GetEnvironmentVariable("ANALYTICS_API_PASSWORD");

        // Add 'ANALYTICS_API_URL' environment variable with api url as value
        public static readonly string BaseUrl = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ANALYTICS_API_URL")) ? Environment.GetEnvironmentVariable("ANALYTICS_API_URL") : "https://api.factset.com";

        public const string DefaultDatesAccount = "CLIENT:Analytics_api/test_account_do_not_delete.acct";
        public const string DefaultLookupDirectory = "client:";
        public const string PADefaultDocument = "PA_DOCUMENTS:DEFAULT";
        public const string PABenchmarkR1000 = "BENCH:R.1000";
        public const string PABenchmarkSP50 = "BENCH:SP50";
        public const string SPARBenchmarkR1000 = "R.1000";
        public const string SPARBenchmarkRussellPR2000 = "RUSSELL_P:R.2000";
        public const string SPARBenchmarkRussellPrefix = "RUSSELL";
        public const string SPARBenchmarkRussellReturnType = "GTR";
        public const string SPARDefaultDocument = "pmw_root:/spar_documents/Factset Default Document";
        public const string VaultDefaultAccount = "CLIENT:/BISAM/REPOSITORY/QA/SMALL_PORT.ACCT";
        public const string VaultDefaultDocument = "Client:/aapi/VAULT_QA_PI_DEFAULT_LOCKED";
        public const string VaultEndDate = "20180331";
        public const string VaultFrequency = "Monthly";
        public const string VaultStartDate = "20180101";
        public const string PubDocumentName = "Client:/AAPI/Puma Test Doc.Pub_bridge_pdf";
        public const string PubAccountName = "BENCH:SP50";
        public const string PubStartDate = "-1M";
        public const string PubEndDate = "0M";
    }
}