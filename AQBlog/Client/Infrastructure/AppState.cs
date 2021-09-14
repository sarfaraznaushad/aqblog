using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AQBlog.Client.Infrastructure
{
    public class AppState
    {
        public string Search { get; private set; }
        public event Action OnChange;
        public void SetVal(string val)
        {
            Search = val;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
