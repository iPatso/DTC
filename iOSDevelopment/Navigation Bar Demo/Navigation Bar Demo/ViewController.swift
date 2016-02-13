//
//  ViewController.swift
//  Navigation Bar Demo
//
//  Created by Patrick Simpelo on 2/13/16.
//  Copyright © 2016 Patrick Simpelo. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
	
	@IBOutlet weak var timeLabel: UILabel!
	var time = 0
	var timer = NSTimer()
	
	@IBAction func playButton(sender: AnyObject) {
		timer = NSTimer.scheduledTimerWithTimeInterval(1, target: self, selector: Selector("result"),
			userInfo: nil, repeats: true)
		
		
		
	}
	
	func result() {
		time++;
		print(time)
		timeLabel.text = "\(time)s";
		
	}
	
	override func viewDidLoad() {
		super.viewDidLoad()
		timeLabel.text = "0s"

		
		
		
		
	}

	override func didReceiveMemoryWarning() {
		super.didReceiveMemoryWarning()
		// Dispose of any resources that can be recreated.
	}


}

