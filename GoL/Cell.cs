using System;
namespace GoL
{
    public class Cell
    {
        
        private Boolean status;
        
        public Cell(bool standardStatus)
        {
            status = standardStatus;
        }
        
        public bool Status { get; set;}
    }
}