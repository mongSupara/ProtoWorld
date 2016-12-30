﻿/* 

This file is part of ProtoWorld. 
	
ProtoWorld is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License along with this library. If not, see <http://www.gnu.org/licenses/>.

Authors of ProtoWorld: Miguel Ramos Carretero, Jayanth Raghothama, Aram Azhari, Johnson Ho and Sebastiaan Meijer. 

*/

/*
 * Historical Data Module
 * 
 * Nathan van Ofwegen
 */
using UnityEngine;

public class fileButtonController : MonoBehaviour {

    public string path;

    private FileBrowserController browser;

	// Use this for initialization
	void Start () {
        browser = GameObject.Find("LoadFileBrowser").GetComponent<FileBrowserController>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void OnSelect()
    {
        browser.showFileInBrowser(path);
    }
}
