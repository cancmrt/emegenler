using System;

namespace Guard.Emegenler.MethodReturner
{
    /// <summary>
    /// Returner logic Emegenler for Success or Failure
    /// </summary>
    /// <typeparam name="T">Returner Type</typeparam>
    public sealed class Returner<T>
    {
        private bool SuccessState { get; set; }
        private bool FailState { get; set; }
        private T SuccessData { get; set; }
        private Exception FailData { get; set; }
        private Returner<T> ReturnerBaseOrginal { get; set; }

        public static Returner<T> SuccessReturn(T returnData)
        {
            Returner<T> ReturnerBase = new Returner<T>
            {
                SuccessState = true,
                FailState = false,
                SuccessData = returnData,
                FailData = null
            };
            ReturnerBase.ReturnerBaseOrginal = ReturnerBase;
            return ReturnerBase;
            
        }
        public static Returner<T> FailReturn(Exception exception)
        {
            Returner<T> ReturnerBase = new Returner<T>
            {
                SuccessState = false,
                SuccessData = default,
                FailState = true,
                FailData = exception
            };
            ReturnerBase.ReturnerBaseOrginal = ReturnerBase;
            return ReturnerBase;
            
        }
        public bool IsSuccess()
        {
            return ReturnerBaseOrginal.SuccessState;
        }
        public bool IsFail()
        {
            return ReturnerBaseOrginal.FailState;
        }
        public T GetData()
        {
            return ReturnerBaseOrginal.SuccessData;
        }
        public Exception GetException()
        {
            return ReturnerBaseOrginal.FailData;
        }

    }
}
