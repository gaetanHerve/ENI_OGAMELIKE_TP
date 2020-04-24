using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGAME_BO
{
    public interface IDbEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        long? Id { get; set; }
    }
}
