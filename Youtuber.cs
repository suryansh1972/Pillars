using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    public class Youtuber : Creator 
    {
        public override void Create()
        {
            if(base.CreativityLevl >= 50 && base.Energy >= 50)
            {
                this.BrainStromVideos();
                this.CreateScript();
                this.VideoTapeScript();
                this.EditingVideo();
            }
            else
            {
                throw new Exception("Loose Monke");
            }
        }
        private void BrainStromVideos()
        {
            base.CreativityLevl = base.CreativityLevl - 1;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Brainstorming solutions .....");
        }
        private void CreateScript ()
        {
            base.CreativityLevl = base.CreativityLevl - 1;
            base.Energy = base.Energy + 5;
            Console.WriteLine("Creating Script .....");
        }
        private void VideoTapeScript()
        {
            base.CreativityLevl = base.CreativityLevl - 1;
            base.Energy = base.Energy + 5;
            Console.WriteLine("VideoTaping script.....");
        }
        private void EditingVideo()
        {
            base.CreativityLevl = base.CreativityLevl - 1;
            base.Energy = base.Energy + 5;
            Console.WriteLine("Editing Video.....");
        }
    }
}
