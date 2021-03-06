//   SparkleShare, a collaboration and sharing tool.
//   Copyright (C) 2010  Hylke Bons <hylkebons@gmail.com>
//
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with this program. If not, see <http://www.gnu.org/licenses/>.


using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using DotCMIS;
using DotCMIS.Client.Impl;
using DotCMIS.Client;
using DotCMIS.Data.Impl;
using DotCMIS.Data.Extensions;

using SparkleLib;

namespace SparkleLib.Cmis {

    public class SparkleRepo : SparkleRepoBase {


        public SparkleRepo (string path, SparkleConfig config) : base (path, config)
        {
			Console.WriteLine("Cmis SparkleRepo constructor");
            Dictionary<string, string> parameters = new Dictionary<string, string>();

			parameters[SessionParameter.BindingType] = BindingType.AtomPub;
			parameters[SessionParameter.AtomPubUrl] = "http://localhost:8080/alfresco/service/cmis";
			parameters[SessionParameter.User] = "admin";
			parameters[SessionParameter.Password] = "admin";

			SessionFactory factory = SessionFactory.NewInstance();
			ISession session = factory.GetRepositories(parameters)[0].CreateSession();
			
			Console.WriteLine("Created CMIS session");
        }


        public override List<string> ExcludePaths {
            get {
				Console.WriteLine("Cmis SparkleRepo ExcludePaths get");
                List<string> rules = new List<string> ();
                rules.Add (".CmisSync"); // Contains the configuration for this checkout
                return rules;
            }
        }


        public override double Size {
            get {
				Console.WriteLine("Cmis SparkleRepo Size get");
                return 1234567; // TODO
            }
        }


        public override double HistorySize {
            get {
				Console.WriteLine("Cmis SparkleRepo HistorySize get");
                return 1234567; // TODO
            }
        }


        private void UpdateSizes ()
        {
			Console.WriteLine("Cmis SparkleRepo UpdateSizes");
			// TODO
        }
        

        public override string [] UnsyncedFilePaths {
            get {
				Console.WriteLine("Cmis SparkleRepo UnsyncedFilePaths get");
                List<string> file_paths = new List<string> ();
                //file_paths.Add (path); TODO
                return file_paths.ToArray ();
            }
        }


        public override string CurrentRevision {
            get {
				Console.WriteLine("Cmis SparkleRepo CurrentRevision get");
                return null; // TODO
            }
        }


        public override bool HasRemoteChanges {
            get {
				Console.WriteLine("Cmis SparkleRepo HasRemoteChanges get");
                return false; // TODO
            }
        }


        public override bool SyncUp ()
        {
			Console.WriteLine("Cmis SparkleRepo SyncUp");
			return true; // TODO
        }


        public override bool SyncDown ()
        {
			Console.WriteLine("Cmis SparkleRepo SyncDown");
			return true; // TODO
        }


        public override bool HasLocalChanges {
            get {
				Console.WriteLine("Cmis SparkleRepo HasLocalChanges get");
				return false; // TODO
            }
        }


        public override bool HasUnsyncedChanges {
            get {
				Console.WriteLine("Cmis SparkleRepo HasUnsyncedChanges get");
				return false; // TODO
            }

            set {
				Console.WriteLine("Cmis SparkleRepo HasUnsyncedChanges set");
				// TODO
            }
        }


        // Stages the made changes
        private void Add ()
        {
			Console.WriteLine("Cmis SparkleRepo Add");
			// TODO
        }


        // Commits the made changes
        private void Commit (string message)
		{
			Console.WriteLine("Cmis SparkleRepo Commit");
			// TODO
        }


        // Merges the fetched changes
        private void Rebase ()
        {
			Console.WriteLine("Cmis SparkleRepo Rebase");
			// TODO
        }


        private void ResolveConflict ()
        {
			Console.WriteLine("Cmis SparkleRepo ResolveConflict");
			// TODO
        }


        public override void RevertFile (string path, string revision)
        {
			Console.WriteLine("Cmis SparkleRepo RevertFile");
			// TODO
        }


        public override List<SparkleChangeSet> GetChangeSets (string path, int count)
        {
			Console.WriteLine("Cmis SparkleRepo GetChangeSets");
            return new List <SparkleChangeSet> (); // TODO
        }   


        public override List<SparkleChangeSet> GetChangeSets (int count)
        {
			Console.WriteLine("Cmis SparkleRepo GetChangeSets");
            return new List <SparkleChangeSet> (); // TODO
        }
    }
}
