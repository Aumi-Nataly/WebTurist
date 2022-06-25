using System;
using System.Collections.Generic;

namespace DataBaseLib.TuristDB.Models
{
    public partial class TblAttractionInterestPoint
    {
        public int Atip { get; set; }
        public int? Pointid { get; set; }
        public int? Atid { get; set; }

        public virtual TblAttractionType? At { get; set; }
        public virtual TblInterestPointCity? Point { get; set; }
    }
}
