//
//  ViewController.swift
//  Table View Demo
//
//  Created by Patrick Simpelo on 2/13/16.
//  Copyright © 2016 Patrick Simpelo. All rights reserved.
//

import UIKit

class ViewController: UIViewController, UITableViewDelegate {

	var cellContents = ["Patrick", "Janelle", "Jemimah", "Dextar", "Doug the Dog"]
	
	override func viewDidLoad() {
		super.viewDidLoad()
		// Do any additional setup after loading the view, typically from a nib.
	}
	
	func tableView(tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
		return cellContents.count
	}
	
	//"indexPath" is the index of what the current row is. So can use for array index (indexPath.row)
	func tableView(tableView: UITableView, cellForRowAtIndexPath indexPath: NSIndexPath) -> UITableViewCell {
		
		let cell = UITableViewCell(style: UITableViewCellStyle.Default, reuseIdentifier: "Cell")
		cell.textLabel?.text = cellContents[indexPath.row]
		return cell
	}

	override func didReceiveMemoryWarning() {
		super.didReceiveMemoryWarning()
		// Dispose of any resources that can be recreated.
	}


}

