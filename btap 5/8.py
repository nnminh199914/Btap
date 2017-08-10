get_even_list = [1, 2, 5, -10, 9, 6]
even_list =[get_even_list for get_even_list in get_even_list if get_even_list % 2 ==0]

if set(even_list) == set([2, -10, 6]):
    print("Your function is correct")
else:
    print("Ooops, bugs detected")
