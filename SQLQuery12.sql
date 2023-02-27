SELECT D.dname
FROM Donor D, BankDonors BD, Bank B
WHERE D.dbloodtype = "A+"
AND B.bname = "GW HOSPITAL BANK"
AND D.did = BD.did
