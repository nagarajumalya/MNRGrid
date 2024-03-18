using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGridExample.Models
{
    //public class GridModel
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public string Desc { get; set; }
    //    public string Date { get; set; }
    //}
    //public class GridModelList
    //{
    //    public List<GridModel> GridData { get; set; }
    //}
    /// <summary>
    /// New Model
    /// </summary>
    public class Metadata
    {
        public double confidenceScore { get; set; }
    }

    public class ResultGridModel
    {
        public int id { get; set; }
        public double score { get; set; }
        public string path { get; set; }
    }
    public class ResultGridModelList
    {
        public List<ResultGridModel> ResultGridData { get; set; }
    }

    public class Root
    {
        public string status { get; set; }
        public int count { get; set; }
        public Metadata metadata { get; set; }
        public List<ResultGridModel> results { get; set; }
    }
}