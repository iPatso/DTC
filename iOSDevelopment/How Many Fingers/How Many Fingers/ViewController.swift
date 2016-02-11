//
//  ViewController.swift
//  How Many Fingers
//
//  Created by Patrick Simpelo on 2/11/16.
//  Copyright © 2016 Patrick Simpelo. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

	var fingersUp:Int! //Initial number WILL be set in viewDidLoad()
	let TOTAL_FINGERS:Int = 5
	
	@IBOutlet weak var feedbackLabel: UILabel!
	@IBOutlet weak var inputTextField: UITextField!
	@IBAction func guessButton(sender: AnyObject) {
		if  inputTextField.text != "" {
			//'!'s at the end overrides "How do you know something is in inputTextField?"
			//	and "How do you know what is in the parens will be a valid Int?"
			let guessedNumber:Int = Int(inputTextField.text!)!
			fingersUp = Int(arc4random_uniform(UInt32(TOTAL_FINGERS))) + 1
			
			if guessedNumber > 0 && guessedNumber <= TOTAL_FINGERS {
				//Valid answer
				if guessedNumber == fingersUp {
					feedbackLabel.text = "Correct!"
				} else {
					feedbackLabel.text = "WRONG! It was \(fingersUp). Try again."
				}
			} else {
				feedbackLabel.text = "Invalid input.\nPlease choose a number" +
									 " between 0 and \(TOTAL_FINGERS)"
			}
		} else {
			feedbackLabel.text = "Please input a number"
		}
	}
	override func viewDidLoad() {
		super.viewDidLoad()

	}

	override func didReceiveMemoryWarning() {
		super.didReceiveMemoryWarning()
		// Dispose of any resources that can be recreated.
	}


}

