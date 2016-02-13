//
//  ViewController.swift
//  Stop Watch
//
//  Created by Patrick Simpelo on 2/13/16.
//  Copyright © 2016 Patrick Simpelo. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

	var timer = NSTimer()
	var time = 0
	@IBOutlet weak var timerLabel: UILabel!
	
	@IBAction func playButton(sender: AnyObject) {
		print("Play button pressed")
		timer = NSTimer.scheduledTimerWithTimeInterval(1, target: self,
			selector: Selector("increaseTimer"),userInfo: nil, repeats: true)
	}
	
	@IBAction func pauseButton(sender: AnyObject) {
		print("Pause button pressed")
		timer.invalidate() //Pauses button
	}
	
	@IBAction func resetButton(sender: AnyObject) {
		print("Reset button pressed")
		timer.invalidate()
		time = 0
		timerLabel.text = "0s"
	}
	
	func increaseTimer() {
		time++
		print(time)
		timerLabel.text = "\(time)s"
	}
	
	override func viewDidLoad() {
		super.viewDidLoad()

		timerLabel.text = "0s"
	}

	override func didReceiveMemoryWarning() {
		super.didReceiveMemoryWarning()
		// Dispose of any resources that can be recreated.
		timerLabel.text = "0s"
		
	}


}

