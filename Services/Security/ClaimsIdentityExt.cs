using System.Security.Claims;

namespace CBDistro.Services.Security
{
    public static class ClaimsIdentityExt
    {
        public static string TENANTID = "CBDistro.TenantId";

        public static void AddTenantId(this ClaimsIdentity claims, object tenantId)
        {
            claims.AddClaim(new Claim(TENANTID, tenantId?.ToString(), null, "CBDistro"));
        }

        public static bool IsTenantIdClaim(this ClaimsIdentity claims, string claimName)
        {
            return claimName == TENANTID;
        }
    }
}