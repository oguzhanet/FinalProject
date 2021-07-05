using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.EmployeeId).NotEmpty();
            RuleFor(o => o.CustomerId).NotEmpty();
            RuleFor(o => o.OrderDate).NotEmpty();
            RuleFor(o => o.ShipCity).NotEmpty();
        }

    }
}
