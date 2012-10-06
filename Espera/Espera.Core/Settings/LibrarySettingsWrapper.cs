﻿using System;

namespace Espera.Core.Settings
{
    public class LibrarySettingsWrapper : ILibrarySettings
    {
        public bool EnablePlaylistTimeout
        {
            get { return CoreSettings.Default.EnablePlaylistTimeout; }
            set { CoreSettings.Default.EnablePlaylistTimeout = value; }
        }

        public bool LockLibraryRemoval
        {
            get { return CoreSettings.Default.LockLibraryRemoval; }
            set { CoreSettings.Default.LockLibraryRemoval = value; }
        }

        public bool LockPlaylistRemoval
        {
            get { return CoreSettings.Default.LockPlaylistRemoval; }
            set { CoreSettings.Default.LockPlaylistRemoval = value; }
        }

        public bool LockPlaylistSwitching
        {
            get { return CoreSettings.Default.LockPlaylistSwitching; }
            set { CoreSettings.Default.LockPlaylistSwitching = value; }
        }

        public bool LockPlayPause
        {
            get { return CoreSettings.Default.LockPlayPause; }
            set { CoreSettings.Default.LockPlayPause = value; }
        }

        public bool LockTime
        {
            get { return CoreSettings.Default.LockTime; }
            set { CoreSettings.Default.LockTime = value; }
        }

        public bool LockVolume
        {
            get { return CoreSettings.Default.LockVolume; }
            set { CoreSettings.Default.LockVolume = value; }
        }

        public TimeSpan PlaylistTimeout
        {
            get { return CoreSettings.Default.PlaylistTimeout; }
            set { CoreSettings.Default.PlaylistTimeout = value; }
        }

        public bool StreamYoutube
        {
            get { return CoreSettings.Default.StreamYoutube; }
            set { CoreSettings.Default.StreamYoutube = value; }
        }

        public bool UpgradeRequired
        {
            get { return CoreSettings.Default.UpgradeRequired; }
            set { CoreSettings.Default.UpgradeRequired = value; }
        }

        public float Volume
        {
            get { return CoreSettings.Default.Volume; }
            set { CoreSettings.Default.Volume = value; }
        }

        public void Save()
        {
            CoreSettings.Default.Save();
        }

        public void Upgrade()
        {
            CoreSettings.Default.Upgrade();
        }
    }
}