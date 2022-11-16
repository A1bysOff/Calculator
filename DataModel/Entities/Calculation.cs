using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class Calculation
    {
        public Guid Id { get; set; }
        public string FirstOperand { get; set; } = null!;
        public string? SecondOperand { get; set; }
        public string Operation { get; set; } = null!;
        public string Result { get; set; } = null!;
        public static Calculation? FindEqualsContent(IEnumerable<Calculation> calculations, Calculation calculation)
        {
            if(calculation == null)
            {
                return null;
            }
            return calculations.FirstOrDefault(x =>
            x.FirstOperand == calculation.FirstOperand &&
            x.Operation == calculation.Operation &&
            x.Result == calculation.Result);
        }
        public static async Task<Calculation?> FindEqualsContentAsync(IEnumerable<Calculation> calculations, Calculation calculation)
        {
            return await Task.Run(() => FindEqualsContent(calculations, calculation));
        }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(SecondOperand))
            {
                return $"{Operation}({FirstOperand}) = {Result}";
            }
            return $"{FirstOperand} {Operation} = {Result}";
        }
    }
}
