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
        private Returner<T> ReturnerBaseOrginal { get; set; }

        public static Returner<T> SuccessReturn(T returnData)
        {
            Returner<T> ReturnerBase = new Returner<T>();
            ReturnerBase.SuccessState = true;
            ReturnerBase.FailState = false;
            ReturnerBase.SuccessData = returnData;
            ReturnerBase.FailData = null;
            ReturnerBase.ReturnerBaseOrginal = ReturnerBase;
            return ReturnerBase;
            
        }
        public static Returner<T> FailReturn(Exception exception)
        {
            Returner<T> ReturnerBase = new Returner<T>();
            ReturnerBase.SuccessState = false;
            ReturnerBase.SuccessData = default(T);
            ReturnerBase.FailState = true;
            ReturnerBase.FailData = exception;
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
