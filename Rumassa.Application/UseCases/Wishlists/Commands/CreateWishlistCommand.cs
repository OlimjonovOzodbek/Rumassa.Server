﻿using MediatR;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.Wishlists.Commands
{
    public class CreateWishlistCommand : IRequest<ResponseModel>
    {
        public Guid UserId { get; set; }
    }
}
