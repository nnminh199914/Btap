
##def remove_S(s):
##    for i in range(len(s)):
##        if i == "$":
##            s.remove(s[i.index])
##    return s
##r = remove_S("asdgashd$aa$")
##print (r)
###em kg hieu sao kg duoc

def remove_S(s):
    a = s.replace('$','')
    return a 
h = remove_S("asdasdasd$$$$dá")
print(h)
string_with_no_dollars = remove_S("$80% percent of $life is to show $up")
if string_with_no_dollars == "80% percent of life is to show up":
    print("Your function is correct")
else:
    print("Oops, there's a bug")
