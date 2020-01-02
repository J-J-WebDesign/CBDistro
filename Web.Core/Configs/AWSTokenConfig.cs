using System;
using System.Collections.Generic;
using System.Text;

namespace CBDistro.Web.Core.Configs
{
    public class AWSTokenConfig
    {
        public string AccessKey { get; set; }
        public string Secret { get; set; }
        public string BucketRegion { get; set; }
        public string Domain { get; set; }
        public string BucketName { get; set; }
    }
}
