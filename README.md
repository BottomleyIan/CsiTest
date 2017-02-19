# CsiTest
## Assumptions
* Sorting will only ever be Ascending or Descending
* Any Integer value means they could be larger than c# MaxInt value
* Sorting int values will be quicker than sorting large int values

## Decisions
* The user will be allowed to enter numbers in a textarea. This allows quicker data entry than typing each number seperately and clicking a button. 
* Values entered in this box that are not integers will just be discarded rather than throw an error.
* I decided to sort the numbers on the server. The client machine could have sorted them first, but I would have had to validate them on post anyway
* The time taken to perform the sort will be measured in milliseconds using the Stopwatch class, even though I expect quite a low number as a result on short lists. I am assuming more accurate measurements and accuracy are beyond the scope of this application.
