﻿Feature: LoanApplication
	In order to buying something nice now
	As a cash poor customer
	I want to borrow money so I don't have to wait

Scenario: Application completed successfully
	Given I am on the loan application screen
		And I enter a first name of Rashiid
		And I enter a second name of Jama
		And I select that I have an existing loan account
		And I confirm my acceptance of the terms and conditions
	When I submit my application
	Then I should see the application complete confirmation for Rashiid



