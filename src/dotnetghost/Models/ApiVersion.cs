namespace dotnetghost.Models
{
    internal static class GhostVersion
    {
        private static string V3 = "/v3/admin/";

        internal static string GetVersionText(ApiVersion version)
        {
            switch(version)
            {
                case ApiVersion.V3:
                    return V3;
                default:
                    return V3;
            }
        }
    }

    public enum ApiVersion
    {
        V3 = 3
    }
}