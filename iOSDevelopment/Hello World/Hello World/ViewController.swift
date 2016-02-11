//
//  ViewController.swift
//  Hello World
//
//  Created by Patrick Simpelo on 2/10/16.
//  Copyright © 2016 Patrick Simpelo. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

	@IBOutlet weak var ageLabel: UILabel!
	@IBOutlet weak var inputTextField: UITextField!
	
	@IBAction func submit(sender: AnyObject) {
		
		print("Button Tapped")
		var age = Int(inputTextField.text!)!
		
		age = age * 10;
		
		ageLabel.text = "Your age times 10 is: \(age)"
		
	}
	
	override func viewDidLoad() {
		super.viewDidLoad()
		
		print("Hello Pat!")
		
	}

	override func didReceiveMemoryWarning() {
		super.didReceiveMemoryWarning()
		// Dispose of any resources that can be recreated.
	}


}

