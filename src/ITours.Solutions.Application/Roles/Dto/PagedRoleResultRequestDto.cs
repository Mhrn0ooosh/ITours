using Abp.Application.Services.Dto;

namespace ITours.Solutions.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

