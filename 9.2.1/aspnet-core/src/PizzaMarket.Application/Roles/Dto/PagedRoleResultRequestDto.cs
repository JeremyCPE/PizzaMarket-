using Abp.Application.Services.Dto;

namespace PizzaMarket.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

