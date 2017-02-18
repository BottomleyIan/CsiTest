# CsiTest
## Assumptions
* Sorting will only ever be Ascending or Descending
* Any Integer value means they could be larger than c# MaxInt value
* Sorting int values will be quicker than sorting large int values

## Decisions
* The user will be allowed to enter numbers in a textarea. This allows quicker data entry than typing each number seperately and clicking a button. 
* Values entered in this box that are not integers will just be discarded rather than throw an error.
