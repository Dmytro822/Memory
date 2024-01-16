using Memo.ViewModels;
using Memo.Models;
using Memo.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memo.Infrastructure.Commands
{
    public class FieldClickCommand : Command
    {
        public override void Execute(object parameters)
        {
            object[] param = parameters as object[];
            Field field = param[0] as Field;
            MainViewModel model = param[1] as MainViewModel;
            model.ClickField(field);
        }
    }
}
