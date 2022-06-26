using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataBaseLib.TuristDB.Models
{
    public partial class TblInterestPointCity
    {
        public TblInterestPointCity()
        {
            TblAttractionInterestPoints = new HashSet<TblAttractionInterestPoint>();
        }

        public int PointId { get; set; }
        public int? CityId { get; set; }
        public string? PointName { get; set; }
        public string? SummaryInfo { get; set; }

        public virtual TblCity? City { get; set; }
        public virtual ICollection<TblAttractionInterestPoint> TblAttractionInterestPoints { get; set; }
    }
}
