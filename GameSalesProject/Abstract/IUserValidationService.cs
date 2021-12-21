using GameSalesProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Abstract
{
    public interface IUserValidationService
    {
        bool IsValid(Gamer gamer);
    }
}
