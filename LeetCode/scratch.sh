function remove_first_page() {
    pdftk "$1" cat 2-end output "$1.temp.pdf"
    mv "$1.temp.pdf" "$1"
}
alias rmpage1=remove_first_page

eval "$(fzf --zsh)"