using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class DecoratorAbstract : Component
    {
        protected Component? component;

        // 設定其他的component
        public void SetComponent(Component component)
        {
            this.component = component;
        }

        // 執行被設定進來的component
        public override void Operation()
        {
            if (this.component != null)
            {
                this.component.Operation();
            }
        }

    }
}
