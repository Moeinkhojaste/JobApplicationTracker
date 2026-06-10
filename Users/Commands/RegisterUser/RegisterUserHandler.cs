using JobTracker.Application.Common.Interfaces;
using JobTracker.Domain.Entities;
using MediatR;
using JobTracker.Application.Users.Commands.RegisterUser;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;

namespace JobTracker.Application.Users.Commands.RegisterUser
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Guid>
    {
        private readonly IApplicationDbContext _applicationDbContext; // we create a private field to hold the reference to the database context
        public RegisterUserHandler(IApplicationDbContext applicationDbContext) 
        {
           _applicationDbContext = applicationDbContext; // we inject the database context into the constructor and assign it to the private field
        }

        public async Task<Guid> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                Username = request.Username,
                Email = request.Email,
                PasswordHash = request.Password // In a real application, you should hash the password before storing it

            };
            _applicationDbContext.Users.Add(user); // we add the new user to the database context
            await _applicationDbContext.SaveChangesAsync();
            return user.Id; // we return the Id of the newly created user
        }
    }
}
