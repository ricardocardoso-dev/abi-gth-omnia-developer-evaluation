using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

/// <summary>
/// Handler for processing ListUsersQuery requests
/// </summary>
public class ListUsersHandler : IRequestHandler<ListUsersQuery, List<ListUsersItem>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of ListUsersHandler
    /// </summary>
    /// <param name="userRepository">The user repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for ListUsersQuery</param>
    public ListUsersHandler(
        IUserRepository userRepository,
        IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the ListUsersQuery request
    /// </summary>
    /// <param name="query">The query to list all users</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of users</returns>
    public async Task<List<ListUsersItem>> Handle(ListUsersQuery query, CancellationToken cancellationToken)
    {
        var validator = new ListUsersValidator();
        var validationResult = await validator.ValidateAsync(query, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var allUsers = await _userRepository.GetAllAsync(query.Page, query.PageSize, cancellationToken);

        return _mapper.Map<List<ListUsersItem>>(allUsers);
    }
}
