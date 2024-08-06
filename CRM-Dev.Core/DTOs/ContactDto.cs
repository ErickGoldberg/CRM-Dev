using CRM_Dev.Core.ValueObjects;

namespace CRM_Dev.Core.DTOs
{
    public sealed record ContactDto(
        string Name,
        string Email,
        string Phone,
        AreaOfExpertise ExpertiseArea,
        string Position,
        string CnpjCpf,
        Address Address,
        string Notes
    );
}
