const bookName = 'Cigar Parties for Koalas';
const bookDescription = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
const reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue (I hope that's glue) and there's writing on it, in some language.",
    rating: 3
  },
  {
    reviewer: 'Tim Ferriss',
    title: 'Had a cigar party started in less than 4 hours.',
    review:
      "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
    rating: 4
  },
  {
    reviewer: 'Ramit Sethi',
    title: 'What every new entrepreneurs needs. A door stop.',
    review:
      "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
    rating: 1
  },
  {
    reviewer: 'Gary Vaynerchuk',
    title: 'And I thought I could write',
    review:
      "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
    rating: 3
  }
];

/**
 * Add our product name to the page title
 * Get our page page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  const pageTitle = document.getElementById('page-title');
  pageTitle.querySelector('.name').innerText = bookName;
  // Another way: const nameElement = document.querySelector('#page-title > span').innerText = bookName;
  // A third way: document.querySelector('#page-title > span').innerText = bookName;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  document.querySelector('p.description').innerText = bookDescription;
}

/**
 * I will display all of the reviews on the page.
 * I will loop over the array of reviews and use some helper functions
 * to create the elements needed for our markup and add them to the DOM
 */
function displayReviews() {
  const mainDiv = document.getElementById('main');

  reviews.forEach((review) => {
    const container = document.createElement('div');
    container.classList.add('review');
    addReviewer(container,review.reviewer);
    addRating(container,review.rating);
    addTitle(container,review.title);
    addReview(container,review.review);
    //container.setAttribute('class','review');
    //container.innerText = review.title;
    mainDiv.insertAdjacentElement('beforeend',container);
  })
}

/**
 * I will creating a new h4 element with the name of the reviewer and append it to
 * the parent element that is passed to me.
 *
 * @param {HTMLElement} parent: The element to append the reviewer to
 * @param {string} name The name of the reviewer
 */
function addReviewer(parent, name) {
  const reviewerH4 = document.createElement('h4');
  reviewerH4.innerText = name;
  parent.appendChild(reviewerH4);
}

/**
 * I will add the rating div along with a star image for the number of ratings 1-5
 * @param {HTMLElement} parent
 * @param {Number} numberOfStars
 */
function addRating(parent, numberOfStars) {
  const starsContainer = document.createElement('div');
  starsContainer.classList.add('rating')
  for(let i = 0; i < numberOfStars; i++)
  {
    const star = document.createElement('img');
    star.setAttribute('src','img/star.png');
    starsContainer.appendChild(star);
  }
  parent.appendChild(starsContainer);
}

/**
 * I will add an h3 element along with the review title
 * @param {HTMLElement} parent
 * @param {string} title
 */
function addTitle(parent, title) {
  const titleH3 = document.createElement('h3');
  titleH3.innerText = title;
  parent.appendChild(titleH3);
}

/**
 * I will add the product review
 * @param {HTMLElement} parent
 * @param {string} review
 */
function addReview(parent, review) {
  const reviewText = document.createElement('p');
  reviewText.innerText = review;
  parent.appendChild(reviewText);
}

// set the product reviews page title
setPageTitle();
// set the product reviews page description
setPageDescription();
// display all of the product reviews on our page
displayReviews();
