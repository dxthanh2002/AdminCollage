using Admin.Models;
using AutoMapper;

namespace eProject.Utils;

public class ApplicationMapper : Profile
{
    public ApplicationMapper()
    {
        CreateMap<Admission, AdmissionResponse>().ReverseMap();

    }
}