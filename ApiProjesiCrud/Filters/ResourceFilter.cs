using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiProjesiCrud.Filters
{
    public class ResourceFilter : Attribute, IResourceFilter
    {

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine(" resource filter executing method ");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine(" resource filter executed method ");
        }
    }
}
