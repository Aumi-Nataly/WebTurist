using System;
using System.Collections.Generic;

namespace DataBaseLib.TuristDB.Models
{
    public partial class TblAttractionType
    {
        public TblAttractionType()
        {
            TblAttractionInterestPoints = new HashSet<TblAttractionInterestPoint>();
        }

        public int AtId { get; set; }
        public string? AtName { get; set; }

        public virtual ICollection<TblAttractionInterestPoint> TblAttractionInterestPoints { get; set; }
    }
}
