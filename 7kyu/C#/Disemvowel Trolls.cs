#include <stdio.h>
#include <string.h>

//std::string disemvowel(const std::string& str) {
  std::string disemvowel(std::string s){
    // return
    char chars[] = "aeiouAEIOU";
    for (unsigned int i = 0; i < strlen(chars); ++i)
   {
  s.erase(remove(s.begin(), s.end(), chars[i]), s.end()); 
      }
	return s; // return the copy and place it in string begin
  
}