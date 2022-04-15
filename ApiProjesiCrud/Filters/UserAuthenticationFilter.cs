using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiProjesiCrud.Filters
{
    public class UserAuthenticationFilter:ActionFilterAttribute,IAuthorizationFilter
    {
        
       
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            
        
        }
    }
}
