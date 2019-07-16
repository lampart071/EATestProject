using System;
using TechTalk.SpecFlow;

namespace EAAutoFramework.Base
{
    public class Base
    {

        public readonly ParallelConfig _parallelConfig;

        public Base(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        public TPage GetInstance<TPage>() where TPage : BasePage, new() 
            => (TPage) Activator.CreateInstance(typeof(TPage));

        public TPage As<TPage>() where TPage : BasePage 
            => (TPage)this;

    }
}
