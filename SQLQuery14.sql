	SELECT *
	FROM Donor D
	WHERE NOT EXISTS(SELECT *
	FROM Donor D1, BankDonors BD1, Bank B1
	WHERE D1.did = D.did
	AND B1.bid = BD1.bid
	AND D1.did = BD1.did
	AND B1.bname = 'Georgetown Bank')
