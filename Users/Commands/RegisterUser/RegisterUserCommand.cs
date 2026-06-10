using MediatR;

namespace JobTracker.Application.Users.Commands.RegisterUser
    {
        public class RegisterUserCommand : IRequest<Guid>
    {
            public required string Username { get; set; }
            public required string Email { get; set; }
            public required string Password { get; set; }
        }
    }
