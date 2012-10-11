/*
 * This file is a part of the Razor Framework.
 * 
 * Copyright (C) 2004 Mark (Code6) Belles 
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 * 
 * */

using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Razor.MultiThreading
{
	#region BackgroundThreadEventArgs

	/// <summary>
	/// Defines an EventArgs class that defines a BackgroundThread event
	/// </summary>
	public class BackgroundThreadEventArgs : EventArgs
	{
		protected BackgroundThread _thread;
		
		/// <summary>
		/// Initializes a new instance of the BackgroundThreadEventArgs class
		/// </summary>
		/// <param name="thread">The background thread about which this event is centered</param>
		public BackgroundThreadEventArgs(BackgroundThread thread) : base()
		{
			_thread = thread;
		}
		
		/// <summary>
		/// Returns the thread about which this event is centered
		/// </summary>
		public BackgroundThread Thread
		{
			get
			{
				return _thread;
			}
		}
	}

	public delegate void BackgroundThreadEventHandler(object sender, BackgroundThreadEventArgs e);

	#endregion

}
