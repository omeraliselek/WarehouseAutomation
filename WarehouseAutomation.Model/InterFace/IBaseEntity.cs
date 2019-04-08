using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseAutomation.Model.Enum;

namespace WarehouseAutomation.Model.InterFace
{
    public interface IBaseEntity
    {
        int ID { get; set; }
        DateTime AddDate { get; set; }
        DateTime UpdateDate { get; set; }
        DateTime DeleteDate { get; set; }
        Status Status { get; set; }
    }
}
