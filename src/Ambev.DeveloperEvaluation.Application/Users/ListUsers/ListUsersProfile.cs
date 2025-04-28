using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

/// <summary>
/// AutoMapper profile for mapping User entity to ListUsersResult
/// </summary>
public class ListUsersProfile : Profile
{
    public ListUsersProfile()
    {
        CreateMap<User, ListUsersItem>();
    }
}
