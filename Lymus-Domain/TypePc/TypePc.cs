using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lymus_Domain.TypePc
{
    public enum TypePc
    {
        [Display(Name = "Игровой")]
        GamingPc =0,
        [Display(Name = "Средний")]
        MediumPc = 0,
        [Display(Name = "Мощный")]
        PowerfulPc = 0,
        [Display(Name = "Персональный")]
        PersonalPc = 0,
    }
}
