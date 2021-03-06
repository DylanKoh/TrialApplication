﻿using System;
using System.IO;
using TrialApplication.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrialApplication
{
    public partial class App : Application
    {
        static NoteDatabase database;
        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
           
            MainPage = new NavigationPage(new NotePage());
        }
        

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
