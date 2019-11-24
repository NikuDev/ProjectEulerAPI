using ProjectEulerAPI.Models.EulerProblems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerAPI.Services
{
    public class EulerService
    {
        private readonly List<IEulerProblem> _eulerProblems;

        public EulerService()
        {
            this._eulerProblems = new List<IEulerProblem>()
            {
                new EulerProblem1(),
                new EulerProblem2(),
                new EulerProblem3(),
                new EulerProblem4(),
                new EulerProblem5()
            };       
        }

        public int GetResultForEulerProblem(int eulerId)
        {
            var eulerProblem = this._eulerProblems.FirstOrDefault(ep => ep.GetType().Name.EndsWith(eulerId.ToString()));

            if (eulerProblem != null)
            {
                return eulerProblem.GetResult();
            }

            throw new ArgumentException("No solution found for this id");
        }
    }
}
