using System;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace ESO___Skill_Point_Calculator
{
    class WMPlayer
    {
        WindowsMediaPlayer wmplayer = new WindowsMediaPlayer();
        Collection collection = new Collection();

        public void BackroundPlayerStart()
        {
            try
            {
                wmplayer.URL = Path.Combine(collection.source, collection.sound);
                wmplayer.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }

        public void BackroundPlayerClose()
        {
            try
            {
                wmplayer.URL = Path.Combine(collection.source, collection.sound);
                wmplayer.controls.stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }

        public void BackroundPlayerPause()
        {
            try
            {
                wmplayer.URL = Path.Combine(collection.source, collection.sound);
                wmplayer.controls.pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }
    }
}
