using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemos
{
    public interface INokiaExtendedFeature: INokiaBasicFeature
    {
        void SendImages();
        void VideoCall();
    }
}
