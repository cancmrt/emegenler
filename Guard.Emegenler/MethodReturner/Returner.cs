using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.MethodReturner
{
    public sealed class Returner<T>
    {
        private bool SuccessState { get; set; }
        private bool FailState { get; set; }
        private T SuccessData { get; set; }
        private Exception FailData { get; set; }
        private static Returner<T> ReturnerBase = new Returner<T>();

        public static Returner<T> SuccessReturn(T returnData)
        {
            ReturnerBase.SuccessState = true;
            ReturnerBase.FailState = false;
            ReturnerBase.SuccessData = returnData;
            ReturnerBase.FailData = null;
            return ReturnerBase;
            
        }
        public static Returner<T> FailReturn(Exception exception)
        {
            ReturnerBase.SuccessState = false;
            ReturnerBase.SuccessData = default(T);
            ReturnerBase.FailState = true;
            ReturnerBase.FailData = exception;
            return ReturnerBase;
            
        }
        public bool IsSuccess()
        {
            return ReturnerBase.SuccessState;
        }
        public bool IsFail()
        {
            return ReturnerBase.FailState;
        }
        public T GetData()
        {
            return ReturnerBase.SuccessData;
        }
        public Exception GetException()
        {
            return ReturnerBase.FailData;
        }

    }
}
